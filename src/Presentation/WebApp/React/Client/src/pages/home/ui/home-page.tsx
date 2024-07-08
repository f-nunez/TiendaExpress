import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export const HomePage = () => {
    useTitle('Home');

    return (
        <section className='bd-content'>
            <PageTitle title='Home'></PageTitle>
            <p>Bootstrap utilizes Sass for a modular and customizable architecture. Import only the components you need, enable global options like gradients and shadows, and write your own CSS with our variables, maps, functions, and mixins.</p>
        </section>
    );
}