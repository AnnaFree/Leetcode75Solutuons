#include "ContainerMax.h"
#include <vector>
#include <algorithm>
int maxArea(std::vector<int>& height) {
    int max_area = 0;
    int i = 0, j = height.size() - 1;

    
    while (i < j) {
        // Calculate area
        int current_area = (j - i) * std::min(height[i], height[j]);
        max_area = std::max(max_area, current_area);

        // Move the pointer of the shorter line towards the other pointer
        if (height[i] < height[j]) {
            i++;  // Move left pointer
        }
        else {
            j--;  // Move right pointer
        }
    }

    return max_area;
}