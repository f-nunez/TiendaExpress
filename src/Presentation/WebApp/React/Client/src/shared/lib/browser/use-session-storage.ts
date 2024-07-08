export const useSessionStorage = {
    getItem,
    setItem,
    removeItem,
    clear
}

function getItem<T>(key: string): T | null {
    const item = sessionStorage.getItem(key);

    return item ? JSON.parse(item) as T : null;
}

function setItem<T>(key: string, value: T): void {
    sessionStorage.setItem(key, JSON.stringify(value));
}

function removeItem(key: string): void {
    sessionStorage.removeItem(key);
}

function clear(): void {
    sessionStorage.clear();
}