import { RootState } from '~app/store';
import { routePath } from '~shared/router';

export const selectIsAuthorized = (state: RootState) =>
    state.session.isAuthorized;

export const selectRedirectionPath = (state: RootState) => {
    const redirectPath = state.session.redirectPath;

    switch (redirectPath.toLowerCase()) {
        case routePath.catalog():
            return routePath.catalog();
        default:
            return routePath.home();
    }
}

export const selectUser = (state: RootState) =>
    state.session.user;

export const selectUsername = (state: RootState) =>
    state.session.user?.username;