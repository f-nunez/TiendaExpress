import { createAction, props } from '@ngrx/store';
import { LoginUserDto, User } from './types';

export const getCurrentUser = createAction(
    '[Session] getCurrentUser',
);

export const getCurrentUserFailure = createAction(
    '[Session] getCurrentUserFailure'
);

export const getCurrentUserSuccess = createAction(
    '[Session] getCurrentUserSuccess',
    props<{ user: User | null }>()
);

export const loginUser = createAction(
    '[Session] loginUser',
    props<{ loginUserDto: LoginUserDto }>()
);

export const loginUserFailure = createAction(
    '[Session] loginUserFailure'
);

export const loginUserSuccess = createAction(
    '[Session] loginUserSuccess',
    props<{ user: User | null }>()
);

export const logout = createAction(
    '[Session] logout'
);

export const logoutSuccess = createAction(
    '[Session] logoutSuccess'
);

export const setRedirectionPath = createAction(
    '[Session] setRedirectionPath',
    props<{ redirectPath: string }>()
);