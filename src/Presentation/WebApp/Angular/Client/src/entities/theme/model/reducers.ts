import { createReducer, on } from '@ngrx/store';
import { actions } from '.';
import { ThemeColor } from './types';

export interface ThemeState {
    currentThemeColor: ThemeColor
}

const initialState: ThemeState = {
    currentThemeColor: window.matchMedia('(prefers-color-scheme: dark)').matches
        ? ThemeColor.Dark
        : ThemeColor.Light
};

export const themeReducer = createReducer(
    initialState,
    on(actions.changeThemeColor, state => ({ ...state })),
    on(actions.changeThemeColorSuccess, (state, { themeColor }) => ({ ...state, currentThemeColor: themeColor })),
    on(actions.getCurrentThemeColor, state => ({ ...state })),
    on(actions.getCurrentThemeColorSuccess, (state, { themeColor }) => ({ ...state, currentThemeColor: themeColor }))
);
