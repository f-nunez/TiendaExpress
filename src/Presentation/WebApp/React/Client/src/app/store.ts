import { configureStore } from '@reduxjs/toolkit';
import { sessionModel } from '~entities/session';
import { themeModel } from '~entities/theme';

const store = configureStore({
    reducer: {
        session: sessionModel.reducers.sessionReducer,
        theme: themeModel.reducers.themeReducer
    }
});

export default store;

// Infer the `RootState` and `AppDispatch` types from the store itself
export type RootState = ReturnType<typeof store.getState>;
// Inferred type: {posts: PostsState, comments: CommentsState, users: UsersState}
export type AppDispatch = typeof store.dispatch;