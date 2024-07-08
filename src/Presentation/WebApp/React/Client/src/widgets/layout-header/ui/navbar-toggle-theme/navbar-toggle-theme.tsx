import { themeModel } from '~entities/theme';
import { ThemeColor } from '~entities/theme/model/types';
import { useAppDispatch, useAppSelector } from '~shared/lib/store';

export interface ThemeColorDropdownItem {
    iconClass: string
    isSelected: boolean
    text: string
    themeColor: ThemeColor
}

export const NavbarToggleTheme = () => {
    const dispatch = useAppDispatch();

    const currentThemeColor = useAppSelector(themeModel.selectors.selectCurrentThemeColor);

    let items: ThemeColorDropdownItem[] = [
        { iconClass: 'bi-sun-fill', isSelected: currentThemeColor == ThemeColor.Light, text: 'Light', themeColor: ThemeColor.Light },
        { iconClass: 'bi-moon-stars-fill', isSelected: currentThemeColor == ThemeColor.Dark, text: 'Dark', themeColor: ThemeColor.Dark },
        { iconClass: 'bi-circle-half', isSelected: currentThemeColor == ThemeColor.Auto, text: 'Auto', themeColor: ThemeColor.Auto }
    ]

    let currentItem: ThemeColorDropdownItem = {
        iconClass: 'bi-circle-half',
        isSelected: currentThemeColor == ThemeColor.Auto,
        text: 'Auto',
        themeColor: ThemeColor.Auto
    }

    items.map((item) => {
        if (item.isSelected)
            currentItem = item
    })

    function clearSelectedItems() {
        items.map((item) => item.isSelected = false);
    }

    function setSelectedItem(themeColor: ThemeColor) {
        items.map((item) => {
            if (item.themeColor == themeColor) {
                item.isSelected = true
                currentItem = item
            }
        });
    }

    function onClickDropdownItem(_event: React.MouseEvent, item: ThemeColorDropdownItem) {
        dispatch(themeModel.actions.changeThemeColor(item.themeColor));
        clearSelectedItems();
        setSelectedItem(item.themeColor);
    }

    setSelectedItem(currentThemeColor);

    return (
        <li className="nav-item dropdown">

            <button className="btn btn-link nav-link py-2 px-0 px-lg-2 dropdown-toggle d-flex align-items-center"
                id="bd-theme"
                type="button"
                aria-expanded="false"
                data-bs-toggle="dropdown"
                data-bs-display="static"
                aria-label="Toggle theme (auto)">
                <i className={`${currentItem.iconClass} theme-icon-active`} id="bd-theme-icon"></i>
                <span className="d-lg-none ms-2" id="bd-theme-text">Toggle theme</span>
            </button>

            <ul className="dropdown-menu dropdown-menu-end" aria-labelledby="bd-theme-text">
                {items.map((item, index) =>
                    <li key={index}>
                        <button type="button" className={`dropdown-item d-flex align-items-center ${item.isSelected ? 'active' : ''}`} aria-pressed="false" onClick={(e) => { onClickDropdownItem(e, item) }}>
                            <i className={`${item.iconClass} me-2 opacity-50`}></i>
                            {item.text}
                            <i className="bi-check2 ms-auto d-none"></i>
                        </button>
                    </li>
                )}
            </ul>

        </li>
    );
}