export interface UserDto {
    id: number;
    created: Date;
    modified: Date;

    userName: string;
    email: string;
    isAdmin: boolean;
    isSuperAdmin: boolean;
}