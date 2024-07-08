import { RootState } from '~app/store';

export const selectCurrentThemeColor = (state: RootState) =>
    state.theme.currentThemeColor;