class _Main {
    var foo = 42;

    function constructor() {
        var f = function() : void {
            log this.foo;
        };

        f(); // says 42
    }

    static function main(args : string[]) : void {
        var o = new _Main();
    }
}