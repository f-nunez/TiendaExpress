import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { User } from './types';

interface AccountState {
    user: User | null,
    isAuthorized: boolean,
    redirectPath: string
}

const initialState: AccountState = {
    user: null,
    isAuthorized: false,
    redirectPath: '/home'
}

export const sessionSlice = createSlice({
    name: 'session',
    initialState,
    reducers: {
        getCurrentUser: (_state) => { },
        getCurrentUserFailure: (state) => {
            state.user = null;
            state.isAuthorized = false;
        },
        getCurrentUserSuccess: (state, action: PayloadAction<User>) => {
            state.user = action.payload;
            state.isAuthorized = true;
        },
        loginUser: (_state) => { },
        loginUserFailure: (state) => {
            state.user = null;
            state.isAuthorized = false;
        },
        loginUserSuccess: (state, action: PayloadAction<User>) => {
            state.user = action.payload;
            state.isAuthorized = true;
        },
        logout: (_state) => { },
        logoutSuccess: (state) => {
            state.user = null;
            state.isAuthorized = false;
        },
        setRedirectionPath: (state, action: PayloadAction<string>) => {
            state.redirectPath = action.payload;
        }
    }
})