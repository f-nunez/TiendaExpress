import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export const ManagerRolePage = () => {
    useTitle('Manager Role');

    return (
        <section className='bd-content'>
            <PageTitle title='Manager Role'></PageTitle>
            <p>Protected by rbac route guard.</p>
        </section>
    );
}