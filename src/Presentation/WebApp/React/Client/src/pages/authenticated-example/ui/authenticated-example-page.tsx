import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export const AuthenticatedExamplePage = () => {
    useTitle('Authenticated');

    return (
        <section className='bd-content'>
            <PageTitle title='Authenticated'></PageTitle>
            <p>Protected by auth route guard.</p>
        </section>
    );
}