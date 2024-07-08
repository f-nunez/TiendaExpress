export const routePath = {
    rootPath: '/',
    authenticatedExample() {
        return routePath.rootPath.concat('authenticated-example');
    },
    catalog() {
        return routePath.rootPath.concat('catalog');
    },
    customerRole() {
        return routePath.rootPath.concat('customer-role');
    },
    home() {
        return routePath.rootPath.concat('');
    },
    managerRole() {
        return routePath.rootPath.concat('manager-role');
    },
    signIn() {
        return routePath.rootPath.concat('sign-in');
    }
}