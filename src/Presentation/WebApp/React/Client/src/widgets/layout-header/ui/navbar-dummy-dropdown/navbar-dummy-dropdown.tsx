export const NavbarDummyDropdown = () => {
    return (
        <li className="nav-item dropdown">

            <button type="button" className="btn btn-link nav-link py-2 px-0 px-lg-2 dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false" data-bs-display="static">
                <span className="d-lg-none" aria-hidden="true">Bootstrap</span><span className="visually-hidden">Bootstrap&nbsp;</span> v5.3 <span className="visually-hidden">(switch to other versions)</span>
            </button>

            <ul className="dropdown-menu dropdown-menu-end">

                <li><h6 className="dropdown-header">Section A</h6></li>

                <li>
                    <a className="dropdown-item d-flex align-items-center justify-content-between active" aria-current="true" href="/docs/5.3/examples/">
                        A - 1
                        <i className="bi-check2"></i>
                    </a>
                </li>

                <li><a className="dropdown-item" href="">A - 2</a></li>

                <li><a className="dropdown-item" href="">A - 3</a></li>

                <li><a className="dropdown-item" href="">A - 4</a></li>

                <li><hr className="dropdown-divider" /></li>

                <li><h6 className="dropdown-header">Section B</h6></li>

                <li><a className="dropdown-item" href="">B - 1</a></li>

                <li><a className="dropdown-item" href="">B - 2</a></li>

                <li><a className="dropdown-item" href="">B - 3</a></li>

                <li><hr className="dropdown-divider" /></li>

                <li><a className="dropdown-item" href="">All options</a></li>

            </ul>

        </li>
    );
}