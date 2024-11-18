//*****************************************************************************
//** 1652. Diffuse the Bomb    leetcode                                      **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* decrypt(int* code, int codeSize, int k, int* returnSize) 
{
    *returnSize = codeSize;
    int* result = (int*)calloc(codeSize, sizeof(int));
    if (result == NULL) 
    {
        return NULL;
    }

    if (k == 0) 
    {
        return result;
    }

    for (int i = 0; i < codeSize; i++) 
    {
        int sum_value = 0;

        if (k > 0) 
        {
            for (int j = 1; j <= k; j++) 
            {
                sum_value += code[(i + j) % codeSize];
            }
        } 
        else if (k < 0) 
        {
            for (int j = 1; j <= -k; j++) 
            {
                sum_value += code[(i - j + codeSize) % codeSize];
            }
        }

        result[i] = sum_value;
    }

    return result;
}