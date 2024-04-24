extern "C"
{
    // Экспорт функции Multiply
    __declspec(dllexport) float Multiply(float a, float b)
    {
        return a * b;
    }
}
