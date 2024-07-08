import { useState, useCallback, useEffect } from 'react';
import { Outlet } from 'react-router-dom';
import { sessionModel } from '~entities/session';
import { themeModel } from '~entities/theme';
import { useAppDispatch } from '~shared/lib/store';
import { wait } from '~shared/lib/util';
import { LayoutFooter } from '~widgets/layout-footer';
import { LayoutHeader } from '~widgets/layout-header';

export const BaseLayout = () => {
    const dispatch = useAppDispatch();

    const [loading, setLoading] = useState(true);

    const initApp = useCallback(async () => {
        try {
            await dispatch(themeModel.thunks.getCurrentThemeColor());
            await dispatch(sessionModel.thunks.getCurrentUser());
            await wait(500);
        } catch (error) {
            console.log(error);
        }
    }, [dispatch]);

    useEffect(() => {
        initApp().then(() => {
            setLoading(false);
        })
    }, [initApp]);

    return (
        <>
            {loading && (
                <div><h1>Loading app...</h1></div>
            )}

            {!loading && (
                <>
                    <LayoutHeader />

                    <main>
                        <div className='container-xxl bd-gutter py-5'>
                            <Outlet />
                        </div>
                    </main>

                    <LayoutFooter />
                </>
            )}
        </>
    );
}