import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { rbacRouteGuard } from '~app/routers/rbac-route-guard';
import { ERole } from '~entities/session/model/types';
import { routePath } from '~shared/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: routePath.home(),
    pathMatch: 'full'
  },
  {
    path: routePath.home(),
    loadChildren: () => import('~pages/home/home-page.module').then(module => module.HomePageModule)
  },
  {
    path: routePath.catalog(),
    loadChildren: () => import('~pages/catalog/catalog-page.module').then(module => module.CatalogPageModule)
  },
  {
    path: routePath.signIn(),
    loadChildren: () => import('~pages/sign-in/sign-in-page.module').then(module => module.SignInPageModule)
  },
  {
    path: routePath.authenticatedExample(),
    loadChildren: () => import('~pages/authenticated-example/authenticated-example-page.module').then(module => module.AuthenticatedExamplePageModule),
    canActivate: [rbacRouteGuard],
    data: { roles: [] }
  },
  {
    path: routePath.customerRole(),
    loadChildren: () => import('~pages/customer-role/customer-role-page.module').then(module => module.CustomerRolePageModule),
    canActivate: [rbacRouteGuard],
    data: { roles: [ERole.Customer] }
  },
  {
    path: routePath.managerRole(),
    loadChildren: () => import('~pages/manager-role/manager-role-page.module').then(module => module.ManagerRolePageModule),
    canActivate: [rbacRouteGuard],
    data: { roles: [ERole.Manager] }
  },
  {
    path: '**',
    loadChildren: () => import('~pages/not-found/not-found-page.module').then(module => module.NotFoundPageModule)
  },
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class BaseLayoutRoutingModule { }