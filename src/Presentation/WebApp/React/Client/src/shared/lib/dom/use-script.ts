import { useEffect } from 'react';

export const useScript = (url: string, integrity: string = '', async: boolean = true, crossOrigin: string = "anonymous") => {
    useEffect(() => {
        const script = document.createElement("script");

        script.src = url;

        script.async = async;

        if (integrity) {
            script.integrity = integrity;
        }

        script.crossOrigin = crossOrigin;

        document.body.appendChild(script);

        return () => {
            document.body.removeChild(script);
        }
    }, [url, integrity, async, crossOrigin]);
}