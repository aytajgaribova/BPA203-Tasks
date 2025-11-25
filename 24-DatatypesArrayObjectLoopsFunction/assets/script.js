//1
function removeDuplicates(arr) {
    const counts = {};
    const result = [];  
    arr.forEach(num => {
        counts[num] = (counts[num] || 0) + 1;
    });

    arr.forEach(num => {
        if (!result.includes(num)) {
            result.push(num);
        }
    });
    console.log("Təkrar olunan reqemler:");
    for (let key in counts) {
        if (counts[key] > 1) {
            console.log(key + " -> " + counts[key] + " dəfə");
        }
    }
    return result;
}
console.log(removeDuplicates([1, 3, 4, 1, 5, 3, 3]));

//2
function isPalindrome(word) {
    word = word.toLowerCase();
    return word === word.split("").reverse().join("");
}

console.log(isPalindrome("level")); 
console.log(isPalindrome("salam")); 
//3
function countSmaller(arr, n) {
    let count = 0;

    arr.forEach(x => {
        if (x < n) count++;
    });

    return count;
}

console.log(countSmaller([5, 12, 3, 7, 1], 6)); 
//4
function abundantOrDeficient(n) {
    let sum = 0;

    for (let i = 1; i < n; i++) {
        if (n % i === 0) {
            sum += i;
        }
    }

    if (sum > n) return "Abundant";
    return "Deficient";
}

console.log(abundantOrDeficient(12)); // Abundant
console.log(abundantOrDeficient(13)); // Deficient

//5
function squareArray(arr) {
    return arr.map(x => x * x);
}

console.log(squareArray([1, 2, 3, 4])); // [1, 4, 9, 16]
