import { NgModule } from '@angular/core';
import * as NgrxStore from '@ngrx/store';
import { rootEffects, rootReducers } from './store';
import { StoreRouterConnectingModule } from '@ngrx/router-store';
import { EffectsModule } from '@ngrx/effects';

@NgModule({
  declarations: [],
  imports: [
    NgrxStore.StoreModule.forRoot(
      rootReducers,
      {
        runtimeChecks: {
          strictActionImmutability: true,
          strictActionSerializability: true,
          strictActionTypeUniqueness: true,
          strictActionWithinNgZone: true,
          strictStateImmutability: true,
          strictStateSerializability: true
        }
      }
    ),
    StoreRouterConnectingModule.forRoot(),
    EffectsModule.forRoot(rootEffects)
  ]
})
export class StoreModule { }
