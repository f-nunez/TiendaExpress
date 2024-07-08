import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { catchError, exhaustMap, map, of } from 'rxjs';
import { LocalStorageService } from '~shared/services/local-storage.service';
import { actions } from '.';
import { SessionApiService } from '../api';

@Injectable()
export class SessionEffects {
    constructor(
        private actions$: Actions,
        private localStorageService: LocalStorageService,
        private sessionApiService: SessionApiService
    ) { }

    getCurrentUser$ = createEffect(() => this.actions$.pipe(
        ofType(actions.getCurrentUser),
        exhaustMap(() => this.sessionApiService.getCurrentUser().pipe(
            map(user => {
                if (user) {
                    //TODO: move storage setitem to getCurrentUserSuccess$ effect case
                    this.localStorageService.setItem('user', user);
                    return actions.getCurrentUserSuccess({ user });
                } else {
                    //TODO: move storage setitem to getCurrentUserFailure$ effect case
                    this.localStorageService.removeItem('user');
                    return actions.getCurrentUserFailure();
                }
            }),
            catchError((_error) => {
                this.localStorageService.removeItem('user');
                return of(actions.getCurrentUserFailure());
            })
        ))
    ));

    loginUser$ = createEffect(() => this.actions$.pipe(
        ofType(actions.loginUser),
        exhaustMap(action => this.sessionApiService.login(action.loginUserDto).pipe(
            map(user => {
                if (user) {
                    //TODO: move storage setitem to getCurrentUserSuccess$ effect case
                    this.localStorageService.setItem('user', user);
                    return actions.loginUserSuccess({ user });
                } else {
                    //TODO: move storage setitem to getCurrentUserFailure$ effect case
                    this.localStorageService.removeItem('user');
                    return actions.loginUserFailure();
                }
            })
        ))
    ));

    logout$ = createEffect(() => this.actions$.pipe(
        ofType(actions.logout),
        map(() => {
            this.localStorageService.removeItem('user');
            return actions.logoutSuccess();
        })
    ));
}