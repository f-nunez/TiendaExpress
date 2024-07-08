import { sessionModel } from '~entities/session';
import { useAppSelector } from '~shared/lib/store';
import { NavbarBrand } from './navbar-brand';
import { NavbarDivider } from './navbar-divider';
import { NavbarDummyDropdown } from './navbar-dummy-dropdown';
import { NavbarLoginMenu } from './navbar-login-menu';
import { NavbarNavigation } from './navbar-navigation';
import { NavbarProfileMenu } from './navbar-profile-menu';
import { NavbarSocialLinks } from './navbar-social-links';
import { NavbarToggleTheme } from './navbar-toggle-theme';

export const LayoutHeader = () => {
    const isAuthorized = useAppSelector(sessionModel.selectors.selectIsAuthorized);

    return (
        <header className='navbar navbar-expand-lg sticky-top bd-navbar'>
            <nav className='container-xxl bd-gutter flex-wrap flex-lg-nowwrap' aria-label='Main navigation'>

                <div className='d-lg-none navbar-brand-filler'></div>

                <NavbarBrand />

                <div className="d-flex">
                    <button className="navbar-toggler d-flex d-lg-none order-3 p-2" type="button" data-bs-toggle="offcanvas" data-bs-target="#bdNavbar" aria-controls="bdNavbar" aria-label="Toggle navigation">
                        <i className="bi-three-dots"></i>
                    </button>
                </div>

                <div className="offcanvas-lg offcanvas-end flex-grow-1" tabIndex={-1} id="bdNavbar" aria-labelledby="bdNavbarOffcanvasLabel" data-bs-scroll="true">

                    <div className="offcanvas-header px-4 pb-0">
                        <h5 className="offcanvas-title text-white" id="bdNavbarOffcanvasLabel">Bootstrap</h5>
                        <button type="button" className="btn-close btn-close-white" data-bs-dismiss="offcanvas" aria-label="Close" data-bs-target="#bdNavbar"></button>
                    </div>

                    <div className="offcanvas-body p-4 pt-0 p-lg-0">

                        <hr className="d-lg-none text-white-50" />

                        <ul className="navbar-nav flex-row flex-wrap bd-navbar-nav">
                            <NavbarNavigation />
                        </ul>

                        <hr className="d-lg-none text-white-50" />

                        <ul className="navbar-nav flex-row flex-wrap ms-md-auto">

                            <NavbarSocialLinks />

                            <NavbarDivider />

                            <NavbarDummyDropdown />

                            <NavbarDivider />

                            <NavbarToggleTheme />

                            <NavbarDivider />

                            {!isAuthorized && (
                                <NavbarLoginMenu />
                            )}

                            {isAuthorized && (
                                <NavbarProfileMenu />
                            )}

                        </ul>

                    </div>

                </div>

            </nav>
        </header>
    );
}