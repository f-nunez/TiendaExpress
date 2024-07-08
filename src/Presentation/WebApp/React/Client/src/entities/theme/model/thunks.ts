import { createAsyncThunk } from '@reduxjs/toolkit';
import { useLocalStorage } from '~shared/lib/browser';
import { ThemeColor } from './types';

export const getCurrentThemeColor = createAsyncThunk<ThemeColor>(
    'theme/getCurrentThemeColor',
    async (_) => {
        const themeColor = useLocalStorage.getItem<ThemeColor>('theme');
        return themeColor ? themeColor : ThemeColor.Auto;
    }
)