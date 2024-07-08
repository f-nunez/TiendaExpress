import { InjectionToken, Type } from '@angular/core';
import * as RouterStore from '@ngrx/router-store';
import { Action, ActionReducerMap } from '@ngrx/store';
import { sessionModel } from '~entities/session';
import { themeModel } from '~entities/theme';

export interface State {
    router: RouterStore.RouterState,
    [themeModel.tokens.THEME_FEATURE_KEY]: themeModel.reducers.ThemeState,
    [sessionModel.tokens.SESSION_FEATURE_KEY]: sessionModel.reducers.AccountState
}

export const rootReducers = new InjectionToken<ActionReducerMap<State, Action>>(
    'Root reducers token',
    {
        factory: () => ({
            router: RouterStore.routerReducer,
            [themeModel.tokens.THEME_FEATURE_KEY]: themeModel.reducers.themeReducer,
            [sessionModel.tokens.SESSION_FEATURE_KEY]: sessionModel.reducers.sessionReducer
        }),
    }
);

export const rootEffects: Type<unknown>[] = [
    themeModel.effects.ThemeEffects,
    sessionModel.effects.SessionEffects
];