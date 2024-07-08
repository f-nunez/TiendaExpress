import { useEffect } from 'react';
import { APP_NAME } from '~shared/config';

export const useTitle = (title?: string | null | undefined) => {
    useEffect(() => {
        if (!title)
            document.title = APP_NAME;
        else
            document.title = `${APP_NAME} - ${title}`;
    }, [title]);
}