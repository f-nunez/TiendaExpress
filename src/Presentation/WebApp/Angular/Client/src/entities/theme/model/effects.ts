import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { map } from 'rxjs';
import { LocalStorageService } from '~shared/services/local-storage.service';
import { actions } from '.';
import { ThemeColor } from './types';

@Injectable()
export class ThemeEffects {
    constructor(private actions$: Actions, private localStorageService: LocalStorageService) { }

    changeThemeColor$ = createEffect(() => this.actions$.pipe(
        ofType(actions.changeThemeColor),
        map(action => {
            const themeColor = action.themeColor;
            this.localStorageService.setItem('theme', themeColor);
            document.documentElement.setAttribute('data-bs-theme', themeColor);
            return actions.changeThemeColorSuccess({ themeColor });
        })
    ));

    getCurrentThemeColor$ = createEffect(() => this.actions$.pipe(
        ofType(actions.getCurrentThemeColor),
        map(() => {
            const storedThemeColor = this.localStorageService.getItem<ThemeColor>('theme');
            const themeColor = storedThemeColor ? storedThemeColor : ThemeColor.Auto;
            document.documentElement.setAttribute('data-bs-theme', themeColor);
            return actions.getCurrentThemeColorSuccess({ themeColor });
        })
    ));
}