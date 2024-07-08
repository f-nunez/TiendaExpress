export const useLocalStorage = {
    getItem,
    setItem,
    removeItem,
    clear
}

function getItem<T>(key: string): T | null {
    const item = localStorage.getItem(key);

    return item ? JSON.parse(item) as T : null;
}

function setItem<T>(key: string, value: T): void {
    localStorage.setItem(key, JSON.stringify(value));
}

function removeItem(key: string): void {
    localStorage.removeItem(key);
}

function clear(): void {
    localStorage.clear();
}