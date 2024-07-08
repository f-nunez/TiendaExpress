import { inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn, Router, RouterStateSnapshot } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { sessionLib, sessionModel } from '~entities/session';
import { ERole, User } from '~entities/session/model/types';
import { routePath } from '~shared/router';

export const rbacRouteGuard: CanActivateFn = (
    route: ActivatedRouteSnapshot, _state: RouterStateSnapshot
) => {
    const store: Store = inject(Store);
    const router: Router = inject(Router);
    const requiredRoles: ERole[] = route.data['roles'];
    let canActivate = true;

    let user$: Observable<User | null> = store
        .select(sessionModel.selectors.selectUser);

    user$.subscribe(user => {
        const routePathForDeniedUser = getRoutePathForDeniedUser(user, requiredRoles);

        if (routePathForDeniedUser) {
            router.navigate([routePathForDeniedUser]);
            canActivate = false;
        } else {
            canActivate = true;
        }
    });

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

    return canActivate;
}
