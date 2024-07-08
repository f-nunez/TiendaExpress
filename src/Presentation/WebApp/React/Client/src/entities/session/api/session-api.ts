import { mapUser } from '../lib';
import { ERole, LoginUserDto, User, UserDto } from '../model/types';

export const sessionApi = {
    login,
    getCurrentUser
}

async function login(params: LoginUserDto): Promise<User | null> {
    // get user data (userDto) from calling backend api

    let userDto: UserDto | null = null;

    if (params.username == 'customer' && params.password == 'customer') {
        userDto = {
            id: '1',
            accessToken: '123',
            refreshAccessToken: '321',
            username: params.username,
            email: `${params.username}@test.com`,
            roles: [ERole.Customer]
        };
    }

    if (params.username == 'manager' && params.password == 'manager') {
        userDto = {
            id: '1',
            accessToken: '123',
            refreshAccessToken: '321',
            username: params.username,
            email: `${params.username}@test.com`,
            roles: [ERole.Manager]
        };
    }

    if (userDto != null)
        return mapUser(userDto);

    return null;
}

async function getCurrentUser(): Promise<User | null> {
    // get current user data (userDto) from calling backend api

    // return null;

    const userDto: UserDto = {
        id: '1',
        accessToken: '123',
        refreshAccessToken: '321',
        username: 'username',
        email: `username@test.com`,
        roles: [ERole.Customer]
    };

    if (userDto)
        return mapUser(userDto);

    return null;
}