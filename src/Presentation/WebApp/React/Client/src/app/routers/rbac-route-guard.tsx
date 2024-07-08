import { Navigate, Outlet } from 'react-router-dom';
import { sessionLib, sessionModel } from '~entities/session';
import { ERole, User } from '~entities/session/model/types';
import { useAppSelector } from '~shared/lib/store';
import { routePath } from '~shared/router';

interface Props {
    roles?: sessionModel.types.ERole[]
}

export default function RbacRouteGuard({ roles }: Props) {
    const user = useAppSelector(sessionModel.selectors.selectUser);

    const routePathForDeniedUser = getRoutePathForDeniedUser(user, roles);

    if (routePathForDeniedUser)
        return <Navigate to={routePathForDeniedUser} />;
    else
        return <Outlet />;
}

function getRoutePathForDeniedUser(user: User | null, requiredRoles: ERole[] | undefined): string {
    if (user == null)
        return routePath.signIn();

    if (requiredRoles === undefined || requiredRoles.length == 0)
        return '';

    const hasAnyRole = sessionLib.roleHelper.existsAnyRoles(user.roles, requiredRoles);

    if (!hasAnyRole)
        return routePath.home();

    return '';
}