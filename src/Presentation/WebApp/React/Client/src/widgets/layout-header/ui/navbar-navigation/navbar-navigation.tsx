import { NavLink } from 'react-router-dom';
import { sessionModel } from '~entities/session';
import { ERole } from '~entities/session/model/types';

export const NavbarNavigation = () => {
    return (
        <>
            <li className="nav-item col-6 col-lg-auto">
                <NavLink className="nav-link py-2 px-0 px-lg-2" to="/">Home</NavLink>
            </li>

            <li className="nav-item col-6 col-lg-auto">
                <NavLink className="nav-link py-2 px-0 px-lg-2" to="/catalog">Catalog</NavLink>
            </li>

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <NavLink className="nav-link py-2 px-0 px-lg-2" to="/authenticated-example">Authenticated Example</NavLink>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <NavLink className="nav-link py-2 px-0 px-lg-2" to="/customer-role">Customer Role</NavLink>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <NavLink className="nav-link py-2 px-0 px-lg-2" to="/manager-role">Manager Role</NavLink>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <a className="nav-link py-2 px-0 px-lg-2" href="https://getbootstrap.com/docs/5.3/getting-started/introduction/" target="_blank" rel="noopener">Docs</a>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <a className="nav-link py-2 px-0 px-lg-2" href="https://getbootstrap.com/docs/5.3/examples/" target="_blank" rel="noopener">Examples</a>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <a className="nav-link py-2 px-0 px-lg-2" href="https://icons.getbootstrap.com/" target="_blank" rel="noopener">Icons</a>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <a className="nav-link py-2 px-0 px-lg-2" href="https://themes.getbootstrap.com/" target="_blank" rel="noopener">Themes</a>
                </li>
            )}

            {sessionModel.hooks.useRequireRole([ERole.Customer, ERole.Manager]) && (
                <li className="nav-item col-6 col-lg-auto">
                    <a className="nav-link py-2 px-0 px-lg-2" href="https://blog.getbootstrap.com/" target="_blank" rel="noopener">Blog</a>
                </li>
            )}
        </>
    );
}