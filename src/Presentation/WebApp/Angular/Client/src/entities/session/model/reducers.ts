import { createReducer, on } from '@ngrx/store';
import { actions } from '.';
import { User } from './types';

export interface AccountState {
    user: User | null,
    isAuthorized: boolean,
    redirectPath: string
}

const initialState: AccountState = {
    user: null,
    isAuthorized: false,
    redirectPath: '/home'
}

export const sessionReducer = createReducer(
    initialState,
    on(actions.getCurrentUser, state => ({ ...state })),
    on(actions.getCurrentUserFailure, state => ({ ...state, user: null, isAuthorized: false })),
    on(actions.getCurrentUserSuccess, (state, { user }) => ({ ...state, user, isAuthorized: true })),
    on(actions.loginUser, state => ({ ...state })),
    on(actions.loginUserSuccess, (state, { user }) => ({ ...state, user, isAuthorized: true })),
    on(actions.logout, state => ({ ...state })),
    on(actions.logoutSuccess, state => ({ ...state, user: null, isAuthorized: false })),
    on(actions.setRedirectionPath, (state, { redirectPath }) => ({ ...state, redirectPath }))
);