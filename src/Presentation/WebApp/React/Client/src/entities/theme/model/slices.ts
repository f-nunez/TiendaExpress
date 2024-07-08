import { createSlice, PayloadAction, isAnyOf } from '@reduxjs/toolkit';
import { useLocalStorage } from '~shared/lib/browser';
import { getCurrentThemeColor } from './thunks';
import { ThemeColor } from './types';

interface ThemeState {
    currentThemeColor: ThemeColor
}

const initialState: ThemeState = {
    currentThemeColor: window.matchMedia('(prefers-color-scheme: dark)').matches
        ? ThemeColor.Dark
        : ThemeColor.Light
}

export const themeSlice = createSlice({
    name: 'theme',
    initialState,
    reducers: {
        changeThemeColor: (state, action: PayloadAction<ThemeColor>) => {
            state.currentThemeColor = action.payload;
            useLocalStorage.setItem('theme', action.payload);
            document.documentElement.setAttribute('data-bs-theme', action.payload);
        },
    },
    extraReducers: (builder) => {
        builder.addMatcher(isAnyOf(getCurrentThemeColor.fulfilled), (state, action) => {
            state.currentThemeColor = action.payload;
            useLocalStorage.setItem('theme', action.payload);
            document.documentElement.setAttribute('data-bs-theme', action.payload);
        })
    }
})