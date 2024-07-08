import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export const CustomerRolePage = () => {
    useTitle('Customer Role');

    return (
        <section className='bd-content'>
            <PageTitle title='Customer Role'></PageTitle>
            <p>Protected by rbac route guard.</p>
        </section>
    );
}