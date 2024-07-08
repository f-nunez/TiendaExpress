import { sessionModel } from '~entities/session';
import { SignOutDropdown } from '~features/authentication/sign-out';
import { useAppSelector } from '~shared/lib/store';

export const NavbarProfileMenu = () => {

    const username = useAppSelector(sessionModel.selectors.selectUsername);

    return (
        <li className="nav-item dropdown">

            <button className="btn btn-link nav-link py-1 px-0 px-lg-2 dropdown-toggle d-flex align-items-center"
                id="bd-login"
                type="button"
                aria-expanded="false"
                data-bs-toggle="dropdown"
                data-bs-display="static"
                aria-label="Profile Menu">

                <a href="#" className="d-block link-body-emphasis text-decoration-none">
                    <img src="https://github.com/mdo.png" alt="mdo" width="32" height="32" className="rounded-circle" />
                </a>

                <span className="d-lg-none ms-2" id="bd-login-text">Profile menu</span>

            </button>

            <ul className="dropdown-menu dropdown-menu-end" aria-labelledby="bd-login-text">

                <li><h6 className="dropdown-header">Welcome, {username}</h6></li>

                <li><a className="dropdown-item">Settings</a></li>

                <li><a className="dropdown-item">Profile</a></li>

                <li><hr className="dropdown-divider" /></li>

                <li><SignOutDropdown /></li>
            </ul>

        </li>
    );
}