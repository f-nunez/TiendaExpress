import { createAction, props } from '@ngrx/store';
import { ThemeColor } from './types';

export const changeThemeColor = createAction(
    '[Theme] changeThemeColor',
    props<{ themeColor: ThemeColor }>()
);

export const changeThemeColorSuccess = createAction(
    '[Theme] changeThemeColorSuccess',
    props<{ themeColor: ThemeColor }>()
);

export const getCurrentThemeColor = createAction(
    '[Theme] getCurrentThemeColor'
);

export const getCurrentThemeColorSuccess = createAction(
    '[Theme] getCurrentThemeColorSuccess',
    props<{ themeColor: ThemeColor }>()
);