import { ERole } from '../model/types';

export const roleHelper = {
    existsAnyRoles
}

function existsAnyRoles(rolesA: ERole[] | undefined, rolesB: ERole[] | undefined): boolean {
    if (!rolesA?.length || !rolesB?.length)
        return false;

    // Find any common element with O(n) complexity
    const setRolesA = new Set(rolesA);

    for (let roleB of rolesB)
        if (setRolesA.has(roleB))
            return true;

    return false;
}