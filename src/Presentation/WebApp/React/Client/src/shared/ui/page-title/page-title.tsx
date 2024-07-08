type Props = {
    title: string
}

export const PageTitle = (props: Props) => {
    return (
        <h2 className='bd-title'>{props.title}</h2>
    );
}