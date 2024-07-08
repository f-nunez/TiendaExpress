export type User = {
    id: string,
    accessToken: string,
    refreshAccessToken: string,
    username: string,
    email: string,
    roles?: ERole[]
}

export type UserDto = {
    id: string,
    accessToken: string,
    refreshAccessToken: string,
    username: string,
    email: string,
    roles?: ERole[]
}

export enum ERole {
    Admin = 'Admin',
    Customer = 'Customer',
    Manager = 'Manager'
}

export type CreateUserDto = {
    username: string,
    email: string,
    password: string
}

export type UpdateUserDto = {
    username: string,
    email: string,
    password: string
}

export type LoginUserDto = {
    username: string,
    password: string
}