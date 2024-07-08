import { sessionSlice } from './slices';

export const { getCurrentUser } = sessionSlice.actions;

export const { getCurrentUserFailure } = sessionSlice.actions;

export const { getCurrentUserSuccess } = sessionSlice.actions;

export const { logout } = sessionSlice.actions;

export const { logoutSuccess } = sessionSlice.actions;

export const { loginUser } = sessionSlice.actions;

export const { loginUserFailure } = sessionSlice.actions;

export const { loginUserSuccess } = sessionSlice.actions;

export const { setRedirectionPath } = sessionSlice.actions;