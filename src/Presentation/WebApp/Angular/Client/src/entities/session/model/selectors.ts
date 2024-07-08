import { createFeatureSelector, createSelector } from '@ngrx/store';
import { routePath } from '~shared/router';
import { AccountState } from './reducers';
import { SESSION_FEATURE_KEY } from './tokens';

export const getSessionState = createFeatureSelector<AccountState>(SESSION_FEATURE_KEY);

export const selectIsAuthorized = createSelector(
    getSessionState,
    (state: AccountState) => state.isAuthorized
);

export const selectRedirectionPath = createSelector(
    getSessionState,
    (state: AccountState) => {
        const redirectPath = state.redirectPath;

        switch (redirectPath.toLowerCase()) {
            case routePath.catalog():
                return routePath.catalog();
            default:
                return routePath.home();
        }
    }
);

export const selectUser = createSelector(
    getSessionState,
    (state: AccountState) => state.user
);

export const selectUsername = createSelector(
    getSessionState,
    (state: AccountState) => state.user?.username
);
