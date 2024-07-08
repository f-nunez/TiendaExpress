import { useTitle } from '~shared/lib/dom';

export const NotFoundPage = () => {
    useTitle('Page not found');

    return (
        <div className='container-xxl bd-gutter py-5'>
            <div className='text-center'>Page not found )":</div>
        </div>
    );
}