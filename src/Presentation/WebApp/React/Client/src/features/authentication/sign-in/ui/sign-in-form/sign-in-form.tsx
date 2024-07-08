import { useEffect } from 'react';
import { useForm, SubmitHandler } from 'react-hook-form';
import { sessionModel } from '~entities/session';
import { LoginUserDto } from '~entities/session/model/types';
import { useAppDispatch, useAppSelector } from '~shared/lib/store';

export type SignInFormProps = {
    onComplete?: (url: string) => void
}

export function SignInForm(props: SignInFormProps) {
    const { register, handleSubmit, formState, getFieldState } = useForm<LoginUserDto>({
        mode: 'onChange',
        defaultValues: { username: '', password: '' }
    });

    const { errors, isSubmitted, isValid } = formState;

    const dispatch = useAppDispatch();

    const redirectionPath = useAppSelector(sessionModel.selectors.selectRedirectionPath);

    const isAuthorized = useAppSelector(sessionModel.selectors.selectIsAuthorized);

    useEffect(() => {
        if (isAuthorized)
            props.onComplete?.(redirectionPath);
    }, [isAuthorized]);

    const onSubmit: SubmitHandler<LoginUserDto> = async (data) => {
        if (!isValid)
            return;

        await dispatch(sessionModel.thunks.loginUser(data));
    }

    return (
        <form
            className={`row g-3 needs-validation ${isSubmitted ? 'was-validated' : ''}`}
            onSubmit={handleSubmit(onSubmit)}
            noValidate>
            <div className='col-12'>
                <label className='form-label' htmlFor='username'>Username</label>

                <input
                    autoComplete='off'
                    className={`form-control ${getFieldState("username").invalid ? 'is-invalid' : ''}`}
                    id='username'
                    maxLength={50}
                    required
                    {...register("username", { required: true, maxLength: 50 })}
                />

                {errors.username?.type === "required" && (
                    <div className="invalid-feedback">
                        Username is required
                    </div>
                )}
            </div>

            <div className='col-12'>
                <label className='form-label' htmlFor='password'>Password</label>

                <input
                    autoComplete='off'
                    className={`form-control ${getFieldState("password").invalid ? 'is-invalid' : ''}`}
                    id='password'
                    maxLength={50}
                    required
                    {...register("password", { required: "Password is required", maxLength: 50 })}
                />

                {errors.password?.type === "required" && (
                    <div className="invalid-feedback">
                        Password is required
                    </div>
                )}
            </div>

            <div className='col-12'>
                <button className="btn btn-primary" type="submit">Login</button>
            </div>
        </form>
    );
}