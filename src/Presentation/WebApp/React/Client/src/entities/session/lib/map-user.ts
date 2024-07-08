import { UserDto, User } from '../model/types';

export async function mapUser(userDto: UserDto): Promise<User> {
    return {
        id: userDto.id,
        accessToken: userDto.accessToken,
        refreshAccessToken: userDto.refreshAccessToken,
        username: userDto.username,
        email: userDto.email,
        roles: userDto.roles
    };
}