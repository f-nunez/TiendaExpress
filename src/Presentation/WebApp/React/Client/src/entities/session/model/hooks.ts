import { useAppSelector } from '~shared/lib/store';
import { ERole } from './types';

export const useRequireRole = (roles: ERole[]): boolean => {
    const userRoles = useAppSelector((state) => state.session.user?.roles);

    if (!roles.length || !userRoles?.length)
        return false;

    return userRoles.some(ur => roles.includes(ur));
}