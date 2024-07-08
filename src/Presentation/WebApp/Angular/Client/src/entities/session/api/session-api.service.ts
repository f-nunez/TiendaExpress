import { Injectable } from '@angular/core';
import { Observable, of, delay } from 'rxjs';
import { mapUser } from '../lib';
import { ERole, LoginUserDto, User, UserDto } from '../model/types';

@Injectable({ providedIn: 'root' })
export class SessionApiService {
    public login(params: LoginUserDto): Observable<User | null> {
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
            return of(mapUser(userDto)).pipe(delay(500));

        return of(null);
    }

    public getCurrentUser(): Observable<User | null> {
        // get current user data (userDto) from calling backend api

        // return of(null).pipe(delay(500));

        const userDto: UserDto = {
            id: '1',
            accessToken: '123',
            refreshAccessToken: '321',
            username: 'username',
            email: `username@test.com`,
            roles: [ERole.Customer]
        };

        if (userDto)
            return of(mapUser(userDto));

        return of(null);
    }
}