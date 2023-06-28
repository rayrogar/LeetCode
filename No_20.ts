namespace Leetcode{
    export class No_20 {
        isValid(s: string): boolean {
            let stack = [], i = 0;

            while (i < s.length) {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    stack.push(s[i]);
                else {
                    let op = stack.pop();
                    switch (op) {
                        case '(':
                            if (s[i] != ')')
                                return false;
                            break;
                        case '[':
                            if (s[i] != ']')
                                return false;
                            break;
                        case '{':
                            if (s[i] != '}')
                                return false;
                            break;
                        default:
                            return false;
                            break;
                    }
                }
                i++;
            }
            return !(stack.length > 0);
        };
    }
}