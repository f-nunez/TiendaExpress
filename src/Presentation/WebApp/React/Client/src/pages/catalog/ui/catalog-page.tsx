import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export const CatalogPage = () => {
    useTitle('Catalog');

    return (
        <section className='bd-content'>
            <PageTitle title='Catalog'></PageTitle>
            <p>Some content here.</p>
        </section>
    );
}