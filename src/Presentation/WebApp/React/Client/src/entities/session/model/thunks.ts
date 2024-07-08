import { createAsyncThunk } from '@reduxjs/toolkit';
import { useLocalStorage } from '~shared/lib/browser';
import { actions } from '.';
import { sessionApi } from '../api';
import { LoginUserDto } from './types';

export const getCurrentUser = createAsyncThunk<void, void>(
    'session/getCurrentUser',
    async (_data, thunkAPI) => {
        try {
            thunkAPI.dispatch(actions.getCurrentUser());
            let user = await sessionApi.getCurrentUser();
            if (user) {
                useLocalStorage.setItem('user', user);
                thunkAPI.dispatch(actions.getCurrentUserSuccess(user));
            } else {
                useLocalStorage.removeItem('user');
                thunkAPI.dispatch(actions.getCurrentUserFailure());
            }
        } catch (_error) {
            useLocalStorage.removeItem('user');
            thunkAPI.dispatch(actions.getCurrentUserFailure());
        }
    }
)

export const loginUser = createAsyncThunk<void, LoginUserDto>(
    'session/loginUser',
    async (data, thunkAPI) => {
        try {
            thunkAPI.dispatch(actions.loginUser());
            let user = await sessionApi.login(data);
            if (user) {
                useLocalStorage.setItem('user', user);
                thunkAPI.dispatch(actions.loginUserSuccess(user));
            } else {
                useLocalStorage.removeItem('user');
                thunkAPI.dispatch(actions.loginUserFailure());
            }
        } catch (_error) {
            useLocalStorage.removeItem('user');
            thunkAPI.dispatch(actions.loginUserFailure());
        }
    }
)

export const logout = createAsyncThunk<void, void>(
    'session/logout',
    async (_data, thunkAPI) => {
        thunkAPI.dispatch(actions.logout());
        useLocalStorage.removeItem('user');
        thunkAPI.dispatch(actions.logoutSuccess());
    }
)
