export async function wait(milliSeconds: number = 100) {
    return await new Promise(resolve => setTimeout(resolve, milliSeconds));
}