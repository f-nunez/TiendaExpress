import { createBrowserRouter } from 'react-router-dom';
import { BaseLayout } from '~app/layouts';
import { ERole } from '~entities/session/model/types';
import { HomePage } from '~pages/home';
import { NotFoundPage } from '~pages/not-found';
import { routePath } from '~shared/router';
import RbacRouteGuard from './rbac-route-guard';

export const router = createBrowserRouter(([
    {
        path: routePath.rootPath,
        element: <BaseLayout />,
        children: [
            {
                path: routePath.home(),
                element: <HomePage />
            },
            {
                path: routePath.catalog(),
                lazy: async () => {
                    let { CatalogPage } = await import("~pages/catalog")
                    return { Component: CatalogPage }
                }
            },
            {
                path: routePath.signIn(),
                lazy: async () => {
                    let { SignInPage } = await import("~pages/sign-in")
                    return { Component: SignInPage }
                }
            },
            {
                element: <RbacRouteGuard />,
                children: [
                    {
                        path: routePath.authenticatedExample(),
                        lazy: async () => {
                            let { AuthenticatedExamplePage } = await import("~pages/authenticated-example")
                            return { Component: AuthenticatedExamplePage }
                        }
                    }
                ]
            },
            {
                element: <RbacRouteGuard roles={[ERole.Customer]} />,
                children: [
                    {
                        path: routePath.customerRole(),
                        lazy: async () => {
                            let { CustomerRolePage } = await import("~pages/customer-role")
                            return { Component: CustomerRolePage }
                        }
                    }
                ]
            },
            {
                element: <RbacRouteGuard roles={[ERole.Manager]} />, children: [
                    {
                        path: routePath.managerRole(),
                        lazy: async () => {
                            let { ManagerRolePage } = await import("~pages/manager-role")
                            return { Component: ManagerRolePage }
                        }
                    }
                ]
            },
            { path: '*', element: <NotFoundPage /> }
        ]
    }
]))