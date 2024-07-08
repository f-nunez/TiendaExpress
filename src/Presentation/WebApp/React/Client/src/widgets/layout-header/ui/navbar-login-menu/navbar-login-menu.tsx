import { useLocation, useNavigate } from 'react-router-dom';
import { sessionModel } from '~entities/session';
import { useAppDispatch } from '~shared/lib/store';
import { routePath } from '~shared/router';

export const NavbarLoginMenu = () => {
    const dispatch = useAppDispatch();
    const location = useLocation();
    const navigate = useNavigate();

    function onClickLogin() {
        const currentPath = location.pathname;

        dispatch(sessionModel.actions.setRedirectionPath(currentPath));

        navigate(routePath.signIn());
    }

    return (
        <li className="nav-item col-6 col-lg-auto">
            <a className='nav-link py-2 px-0 px-lg-2' onClick={onClickLogin}>Login</a>
        </li>
    );
}