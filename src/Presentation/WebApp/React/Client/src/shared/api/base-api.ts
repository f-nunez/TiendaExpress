import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { API_URL } from '~shared/config';


class BaseApi {
    private axios: AxiosInstance;
    private headers = { 'Content-Type': 'application/json' };

    constructor() {
        this.axios = axios.create({
            baseURL: API_URL,
            headers: this.headers
        });
    }

    async get<T>(endpoint: string, options: AxiosRequestConfig = {}): Promise<T> {
        try {
            const response: AxiosResponse<T> = await this.axios.get(
                endpoint,
                options
            );
            return response.data;
        } catch (error) {
            throw error;
        }
    }

    async post<T>(
        endpoint: string,
        data: any,
        options: AxiosRequestConfig = {}
    ): Promise<T> {
        try {
            const response: AxiosResponse<T> = await this.axios.post(
                endpoint,
                data,
                options
            );
            return response.data;
        } catch (error) {
            throw error;
        }
    }

    async put<T>(
        endpoint: string,
        data: any,
        options: AxiosRequestConfig = {}
    ): Promise<T> {
        try {
            const response: AxiosResponse<T> = await this.axios.put(
                endpoint,
                data,
                options
            );
            return response.data;
        } catch (error) {
            throw error;
        }
    }

    async delete<T>(
        endpoint: string,
        options: AxiosRequestConfig = {}
    ): Promise<T> {
        try {
            const response: AxiosResponse<T> = await this.axios.delete(
                endpoint,
                options
            );
            return response.data;
        } catch (error) {
            throw error
        }
    }
}

export const baseApi = new BaseApi();