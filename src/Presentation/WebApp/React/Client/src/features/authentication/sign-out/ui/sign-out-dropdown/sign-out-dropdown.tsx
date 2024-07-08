import { useNavigate } from 'react-router-dom';
import { sessionModel } from '~entities/session';
import { useAppDispatch } from '~shared/lib/store';
import { routePath } from '~shared/router';

export const SignOutDropdown = () => {
    const dispatch = useAppDispatch();
    const navigate = useNavigate();

    function onClickLogout() {
        dispatch(sessionModel.thunks.logout());
        navigate(routePath.home());
    }

    return (
        <a className="dropdown-item" onClick={onClickLogout}>Sign out</a>
    );
}