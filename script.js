
// Your goal in this kata is to implement a difference function, which subtracts
// one list from another and returns the result.
// It should remove all values from list a,
//which are present in list b keeping their order.
// arrayDiff([1,2],[1]) == [2]
// If a value is present in b,
// all of its occurrences must be removed from the other:

// arrayDiff([1,2,2,2,3],[2]) == [1,3]

const a = [];
const b = [4, 5];
arrayDiff(a, b);
function arrayDiff(a, b) {

    for (let i = 0; i <= a.length; i++) {

        b.map((n) => {
            if (a[i] == n) {
                a.splice(i, 1);
            }
        })
    }

    for (let i = 0; i <= a.length; i++) {

        b.map((n) => {
            if (a[i] == n) {
                a.splice(i, 1);
            }
        });
    }
    return a;
}