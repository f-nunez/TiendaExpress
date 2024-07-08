import { createFeatureSelector, createSelector } from '@ngrx/store';
import { ThemeState } from './reducers';
import { THEME_FEATURE_KEY } from './tokens';

export const getThemeState = createFeatureSelector<ThemeState>(THEME_FEATURE_KEY);

export const selectCurrentThemeColor = createSelector(
    getThemeState,
    (state: ThemeState) => state.currentThemeColor
);