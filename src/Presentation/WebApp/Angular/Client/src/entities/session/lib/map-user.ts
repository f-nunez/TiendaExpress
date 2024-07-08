import { UserDto, User } from '../model/types';

export function mapUser(userDto: UserDto): User {
    return {
        id: userDto.id,
        accessToken: userDto.accessToken,
        refreshAccessToken: userDto.refreshAccessToken,
        username: userDto.username,
        email: userDto.email,
        roles: userDto.roles
    };
}