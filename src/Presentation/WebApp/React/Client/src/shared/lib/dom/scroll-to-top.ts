export const scrollToTop = () => {
    document.querySelector("html")?.scrollTo({ top: 0, behavior: "smooth" });
}