import { useCallback } from 'react';
import { useNavigate } from 'react-router-dom';
import { SignInForm } from '~features/authentication/sign-in';
import { useTitle } from '~shared/lib/dom';
import { PageTitle } from '~shared/ui';

export function SignInPage() {
    useTitle('Sign In');

    const navigate = useNavigate();

    const onComplete = useCallback((url: string) => {
        navigate(url);
    }, [navigate]);

    return (
        <section className='bd-content'>
            <PageTitle title='Sign In'></PageTitle>
            <SignInForm onComplete={onComplete}></SignInForm>
        </section>
    );
}